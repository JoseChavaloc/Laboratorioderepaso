using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;


namespace Laboratorioderepaso
{
    internal class EmpleadoArchivo
    {
        public void Guardar(string archivo, List<Empleado> empleados)
        {

            string json = JsonConvert.SerializeObject(empleados);

            System.IO.File.WriteAllText(archivo, json);
        }
        public List<Empleado> Leer(string archivo)
        {


            // Verificar si el archivo no existe
            if (!File.Exists(archivo))
            {
                // Crear una lista vacía
                List<Empleado> listaVacia = new List<Empleado>();

                // Serializar y guardar esa lista vacía como JSON
                string jsonVacio = JsonConvert.SerializeObject(listaVacia, Formatting.Indented);
                File.WriteAllText(archivo, jsonVacio);
            }

            // Leer el contenido del archivo
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();

            // Deserializar el contenido a una lista de empleados
            List<Empleado> lista = JsonConvert.DeserializeObject<List<Empleado>>(json);

            return lista;
        }

    }
}
