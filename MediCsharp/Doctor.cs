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
    
    public enum Especialidad { Clinico, Pediatra, Ginecologo, Dentista, Mastologo, Dermatologo, Oculista, Fonoaudiologo, Psicologo }
    public class Doctor
    {
        public int Id { get; set; }
        public string NombreDoctor { get; set; }
        public string ApellidoDoctor { get; set; }
        public Especialidad especialidad { get; set; }
        public Sexo sexo { get; set; }
        public  Int32 Edad { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }

        public List<string> DiasGuardia { get; set; }


        public static List<Doctor> listaDoctores = new List<Doctor>();

        public static void AgregarDoctor(Doctor d)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"INSERT INTO Doctor (NombreDoctor, ApellidoDoctor, especialidad, sexo, Edad, FechaNacimiento, Telefono, DiasGuardia) VALUES (@NombreDoctor, @ApellidoDoctor, @especialidad, @sexo, @Edad, @FechaNacimiento, @Telefono, @DiasGuardia)";
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
                string textoCmd = @"UPDATE Doctor SET NombreDoctor = @NombreDoctor, ApellidoDoctor = @ApellidoDoctor, especialidad = @especialidad, sexo = @sexo, Edad = @Edad, FechaNacimiento = @FechaNacimiento, Telefono = @Telefono ,DiasGuardia = @DiasGuardia where Id = @Id";
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
                    doctor.Edad = elLectorDeDatos.GetInt32(5);
                    doctor.FechaNacimiento = elLectorDeDatos.GetDateTime(6);
                    doctor.Telefono = elLectorDeDatos.GetString(7);
                    doctor.DiasGuardia = ObtenerListaDiasGuardia(elLectorDeDatos.GetString(8));


                    listaDoctores.Add(doctor);
                }
            }
            return listaDoctores;
        }

        private string ObtenerStringDiasGuardia()
        {
            return string.Join(",", this.DiasGuardia);

        }

        private static List<string> ObtenerListaDiasGuardia(string dias)
        {
            return dias.Split(',').ToList();
        }



        public override string ToString()
        {
            return this.NombreDoctor + " " + ApellidoDoctor;
        }


        private SqlCommand ObtenerParametros(SqlCommand cmd, Boolean Id = false)
        {

            SqlParameter p1 = new SqlParameter("@NombreDoctor", this.NombreDoctor);
            SqlParameter p2 = new SqlParameter("@ApellidoDoctor", this.ApellidoDoctor);
            SqlParameter p3 = new SqlParameter("@especialidad", this.especialidad);
            SqlParameter p4 = new SqlParameter("@sexo", this.sexo);
            SqlParameter p5 = new SqlParameter("@Edad", this.Edad);
            SqlParameter p6 = new SqlParameter("@FechaNacimiento", this.FechaNacimiento);
            SqlParameter p7 = new SqlParameter("@Telefono", this.Telefono);
            SqlParameter p8 = new SqlParameter("@DiasGuardia", this.ObtenerStringDiasGuardia());
            p1.SqlDbType = SqlDbType.VarChar;
            p2.SqlDbType = SqlDbType.VarChar;
            p3.SqlDbType = SqlDbType.Int;
            p4.SqlDbType = SqlDbType.Int;
            p5.SqlDbType = SqlDbType.VarChar;
            p6.SqlDbType = SqlDbType.DateTime;
            p7.SqlDbType = SqlDbType.VarChar;
            p8.SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.Parameters.Add(p6);
            cmd.Parameters.Add(p7);
            cmd.Parameters.Add(p8);

            if (Id == true) cmd = ObtenerParametroId(cmd);

            return cmd;
        }


        private SqlCommand ObtenerParametroId(SqlCommand cmd)
        {
            SqlParameter p9 = new SqlParameter("@Id", this.Id);
            p9.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(p9);

            return cmd;
        }


    }
}
