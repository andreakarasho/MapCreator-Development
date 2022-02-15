using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GenerateMapTemplate
{
    public class MapInfo
    {
        private string m_Name;
        private byte m_Num;
        private int m_XSize;
        private int m_YSize;

        #region Getters And Setters

        public string MapName
        {
            get
            {
                return this.m_Name;
            }
        }

        public byte MapNumber
        {
            get
            {
                return this.m_Num;
            }
        }

        public int XSize
        {
            get
            {
                return this.m_XSize;
            }
        }

        public int YSize
        {
            get
            {
                return this.m_YSize;
            }
        }

        #endregion

        public MapInfo(XmlElement iXml)
        {
            this.m_Name = iXml.GetAttribute("Name");
            this.m_Num = ByteType.FromString(iXml.GetAttribute("Num"));
            this.m_XSize = IntegerType.FromString(iXml.GetAttribute("XSize"));
            this.m_YSize = IntegerType.FromString(iXml.GetAttribute("YSize"));
        }

        public override string ToString()
        {
            return string.Format("{0}", this.m_Name);
        }
    }
}
