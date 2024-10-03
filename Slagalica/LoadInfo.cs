using System;
using System.IO;

namespace Slagalica
{
    public enum Field {
        PIK = 1,
        KARO = 2,
        HERC = 3,
        TREF = 4,
        EMPTY = 0
    }
    class LoadInfo
    {
        public int score;
        public Field[,] m  = new Field[4,4];
        public bool fresh = false;

        public void ResetState()
        {
            fresh = true;
            score = 0;

            Random RandGen = new Random();
            int RandomIndex;
            bool[] UsedIndices = new bool[16];
            for (int i = 0; i < 16; i++) UsedIndices[i] = false;

            for (int i = 0; i < 4; i++)
            {
                do
                {
                    RandomIndex = RandGen.Next() % 16;
                } while (UsedIndices[RandomIndex] == true);

                UsedIndices[RandomIndex] = true;
                m[RandomIndex / 4, RandomIndex % 4] = Field.PIK;
            }
            for (int i = 0; i < 4; i++)
            {
                do
                {
                    RandomIndex = RandGen.Next() % 16;
                } while (UsedIndices[RandomIndex] == true);

                UsedIndices[RandomIndex] = true;
                m[RandomIndex / 4, RandomIndex % 4] = Field.HERC;
            }
            for (int i = 0; i < 4; i++)
            {
                do
                {
                    RandomIndex = RandGen.Next() % 16;
                } while (UsedIndices[RandomIndex] == true);

                UsedIndices[RandomIndex] = true;
                m[RandomIndex / 4, RandomIndex % 4] = Field.TREF;
            }
            /* Tri, a ne cetiri kara. Jedno mjesto se ostavlja za prazno polje. */
            for (int i = 0; i < 3; i++)
            {
                do
                {
                    RandomIndex = RandGen.Next() % 16;
                } while (UsedIndices[RandomIndex] == true);

                UsedIndices[RandomIndex] = true;
                m[RandomIndex / 4, RandomIndex % 4] = Field.KARO;
            }
            RandomIndex = 0;
            while (UsedIndices[RandomIndex] == true) RandomIndex++;

            m[RandomIndex / 4, RandomIndex % 4] = Field.EMPTY;
        }

        public LoadInfo()
        {
            if(File.Exists(Properties.Resources.PreviousStateFileName) == false)
            {
                ResetState();
            }
            else
            {
                FileStream rFile = File.Open(Properties.Resources.PreviousStateFileName, FileMode.Open);
                using(BinaryReader reader = new BinaryReader(rFile))
                {
                    for (int i = 0; i < 16; i++)
                    {
                        int fieldSerial = reader.ReadInt32();
                        Field f;
                        switch(fieldSerial)
                        {
                            case 1:
                                f = Field.PIK;
                                break;
                            case 2:
                                f = Field.KARO;
                                break;
                            case 3:
                                f = Field.HERC;
                                break;
                            case 4:
                                f = Field.TREF;
                                break;
                            default:
                                f = Field.EMPTY;
                                break;
                        }
                        m[i / 4, i % 4] = f;
                    }
                    score = reader.ReadInt32();
                }
            }
        }

        public void Flush()
        {
            FileStream wFile = File.Open(Properties.Resources.PreviousStateFileName, FileMode.OpenOrCreate);
            using (BinaryWriter writer = new BinaryWriter(wFile))
            {
                for(int i = 0; i < 4; i++)
                {
                    for(int j = 0; j < 4; j++)
                    {
                        writer.Write((int) m[i, j]);
                    }
                }
                writer.Write(score);
            }
        }
    }
}