using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConvertTheMapToBMP
{
    class RadarColReader
    {
        private ushort[] m_Colors;
        public ushort[] Colors { get { return m_Colors; } }

        public RadarColReader(string filename)
        {
            m_Colors = new ushort[0x8000];
            BinaryReader reader = new BinaryReader(new FileStream(filename, FileMode.Open));

            for (int i = 0; i < 0x8000; i++)
                m_Colors[i] = reader.ReadUInt16();

            reader.Close();
        }
    }
}
