using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Common
{
    public class XMLSerialization
    {
        /// <summary>
        /// 序列化
        /// </summary>
        /// <param name="filePath">文件路径</param>
        /// <param name="obj">要序列化的实体类</param>
        /// <param name="type">类型</param>
        public static void SaveXml(string filePath, object obj, System.Type type)
        {

            //////序列化 成 XML   文件  Object -- > XML

            //如果文件存在  则先删除原来文件
            if (System.IO.File.Exists(filePath))
                File.Delete(filePath);
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(filePath))
            {
                try
                {
                    System.Xml.Serialization.XmlSerializer xs = new System.Xml.Serialization.XmlSerializer(type);
                    xs.Serialize(writer, obj);
                    writer.Close();
                }
                catch (Exception e)
                {
                    e = e;
                    throw;
                }
            }
            ////////序列化 成 2进制   文件
            //FileStream fs = new FileStream(filePath, FileMode.Create);
            //BinaryFormatter bf = new BinaryFormatter();
            //bf.Serialize(fs, obj);
        }




        /// <summary>
        /// 反序列化
        /// </summary>
        /// <param name="filePath">文件的路径</param>
        /// <param name="type">实体类的类型</param>
        /// <returns>当前实体</returns>
        public static object LoadXml(string filePath, System.Type type)
        {
            //判断文件是否存在
            if (!System.IO.File.Exists(filePath))
                return null;
            ///反序列化  XML  文件     XML -- > Object
            using (System.IO.StreamReader reader = new System.IO.StreamReader(filePath))
            {
                System.Xml.Serialization.XmlSerializer xs = new System.Xml.Serialization.XmlSerializer(type);
                object obj = xs.Deserialize(reader);
                reader.Close();
                return obj;
            }
            /////反序列化  2进制  文件
            //FileStream fs = new FileStream(filePath, FileMode.Open);
            //BinaryFormatter bf = new BinaryFormatter();
            //return (Goods_Entity)bf.Deserialize(fs);
        }
    }
}
