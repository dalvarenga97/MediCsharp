using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//testing
//Prueba

namespace MediCsharp
{
    public enum DiaSemana {Lunes, Martes, Miercoles, Jueves,  Viernes, Sabado, Domingo }
    public enum Especialidad { Clinico, Pediatra, Ginecologo, Dentista, Mastologo, Dermatologo, Oculista, Fonoaudiologo, Psicologo }
    public class Doctor
    {
        public int Id { get; set; }
        public string NombreDoctor { get; set; }
        public string ApellidoDoctor { get; set; }
        public Especialidad especialidad { get; set; }
        public Sexo sexo { get; set; }
        public string Edad { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }

        public List<string> dias_guardia { get; set; }


        public static List<Doctor> listaDoctores = new List<Doctor>();

        public static void AgregarDoctor(Doctor d)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"INSERT INTO Doctor (nombredoctor, apellidodoctor, especialidad, sexo, edad, fechanacimiento, telefono, diasguardia) VALUES (@nombredoctor, @apellidodoctor, @especialidad, @sexo, @edad, @fechanacimiento, @telefono, @diasguardia)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = d.ObtenerParametros(cmd);

                cmd.ExecuteNonQuery();
            }
        }
        public static void EliminarDoctor(Doctor d)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"delete from Doctor where Id = @Id";

                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = d.ObtenerParametroId(cmd);

                cmd.ExecuteNonQuery();
            }
        }

        public static void EditarDoctor(int index, Doctor d)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"UPDATE Doctor SET nombredoctor = @nombredoctor, apellidodoctor = @apellidodoctor, especialidad = @especialidad, sexo = @sexo, edad = @edad, fechanacimiento = @fechanacimiento, telelfono = @telelfono ,dias_guardia = @dias_guardia where id = @id";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = d.ObtenerParametros(cmd, true);

                cmd.ExecuteNonQuery();
            }
        }

        public static List<Doctor> ObtenerDoctor()
        {
            Doctor doctor;
            listaDoctores.Clear();

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = "Select * from Doctor";

                SqlCommand cmd = new SqlCommand(textoCmd, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    doctor = new Doctor();
                    doctor.Id = elLectorDeDatos.GetInt32(0);
                    doctor.NombreDoctor = elLectorDeDatos.GetString(1);
                    doctor.ApellidoDoctor = elLectorDeDatos.GetString(2);
                    doctor.especialidad = (Especialidad)elLectorDeDatos.GetInt32(3);
                    doctor.sexo = (Sexo)elLectorDeDatos.GetInt32(4);
                    doctor.Edad = elLectorDeDatos.GetString(5);
                    doctor.FechaNacimiento = elLectorDeDatos.GetDateTime(6);
                    doctor.Telefono = elLectorDeDatos.GetString(7);
                    doctor.dias_guardia = ObtenerListaDiasEntrega(elLectorDeDatos.GetString(8));


                    listaDoctores.Add(doctor);
                }
            }
            return listaDoctores;
        }

        private string ObtenerStringDiasGuardia()
        {
            return string.Join(",", this.dias_guardia);

        }

        private static List<string> ObtenerListaDiasGuardia(string dias)
        {
            return dias.Split(',').ToList();
        }



        public override string ToString()
        {
            return this.NombreDoctor + " " + ApellidoDoctor;
        }


    }
}
