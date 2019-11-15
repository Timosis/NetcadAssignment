using Grpc.Core;
using Nancy.Json;
using NetcadAssignment.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetcadAssignment.DataService
{
    /// <summary>
    /// Data Service Interface
    /// </summary>
    public interface IFileDataService
    {
        bool IsFileCreated();
        void CreateFile();
        Task<Object> GetShape(char key);
        Task AddShape<TEntity>(TEntity entity);
    }

    /// <summary>
    /// Data Service For Reading and Writing(Read,Insert) File. 
    /// </summary>
    public class FileDataService : IFileDataService
    {

        /// <summary>
        ///  Adding A Shape To File
        /// </summary>
        /// <typeparam name="TEntity">Generic Type Entity</typeparam>
        /// <param name="entity"> To Be Saved Into The File </param>
        public async Task AddShape<TEntity>(TEntity entity)
        {

            List<Object> list = new List<Object>();


            await Task.Run(() =>
            {
                if (!IsFileCreated())
                {
                    CreateFile();
                }
                else
                {
                    string json = JsonConvert.SerializeObject(entity);

                    using (StreamReader textreader = new StreamReader(DbFile.Path + DbFile.Name))
                    {
                        //string json = r.ReadToEnd();
                        //List<O> persons = JsonConvert.DeserializeObject<List<Person>>(json);
                        //persons.Add(person);
                        //string newJson = JsonConvert.SerializeObject(persons);

                        using (var reader = new JsonTextReader(textreader))
                        {
                            while (reader.Read())
                            {
                                if (reader.TokenType == JsonToken.StartObject)
                                {
                                    var obj = JObject.Load(reader);
                                    list.Add(obj);
                                }
                            }
                        }
                        JObject o = JObject.Parse(json);
                        list.Add(o);
                        string newJson = JsonConvert.SerializeObject(list);
                        File.WriteAllText(DbFile.Path + DbFile.Name, newJson);
                    }

                 
                }
            });
        }


        /// <summary>
        ///  Getting A Shape From File.
        /// </summary>
        /// <param name="key">Search Parameter To Get A Shape From File</param>
        /// <returns>string result</returns>
        public async Task<Object> GetShape(char key)
        {
            Object shape = new Object();          
            
            await Task.Run(() =>
            {
                if (!IsFileCreated())
                {
                    CreateFile();
                }
                else
                {
                    using (StreamReader textReader = new StreamReader(DbFile.Path + DbFile.Name))
                    {
                        using (var reader = new JsonTextReader(textReader))
                        {
                            while (reader.Read())
                            {
                                if (reader.TokenType == JsonToken.StartObject)
                                {
                                    var obj = JObject.Load(reader);                                                                   
                                    if (obj["Key"].ToString() == key.ToString())
                                    {
                                        shape = obj;
                                    }
                                }
                            }
                        }
                    }                    
                }
            });

            return shape;
        }

        /// <summary>
        ///  Check The File Is Created Or Not
        /// </summary>
        /// <returns>boolean value</returns>
        public bool IsFileCreated()
        {
            bool isFileExists = File.Exists(DbFile.Path + DbFile.Name);           
            return isFileExists;
        }

        /// <summary>
        /// Create File
        /// </summary>
        public void CreateFile()
        {            
             File.Create(DbFile.Path + DbFile.Name);            
        }
    }
}
