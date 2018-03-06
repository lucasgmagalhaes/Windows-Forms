using System;
using System.Web.Script.Serialization;
namespace CodesGenerationJSON
{   
   /// <summary>
   /// Class that contains a single mathod to generate a json from objects
   /// </summary>
    class Json_generator
    {
        /// <summary>
        /// Genearte a JSON string file from a object
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static Object generateJson(Object entity)
        {
            return new JavaScriptSerializer().Serialize(entity);
        }
    }
}
