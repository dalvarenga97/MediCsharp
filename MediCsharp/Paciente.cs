using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace MediCsharp
{
    public enum Sexo { Femenino, Masculino }
    public enum EstadoCivil { Soltero, Casado, Viudo, Separado }

    public class Paciente
    {
        public int Id { get; set; }
        
        public string NombrePaciente { get; set; }
        public string ApellidoPaciente { get; set; }
        public Sexo sexo { get; set; }
        public Int32 Edad { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Int32 Telefono { get; set; }
        public bool Bandera;
        public EstadoCivil estadocivil { get; set; }

        public static List<Paciente> listaPacientes = new List<Paciente>();

        public static void AgregarPaciente(Paciente p)
        {
            //listaPacientes.Add(p);

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"INSERT INTO Paciente (NombrePaciente, ApellidoPaciente,sexo,Edad,FechaNacimiento,Telefono,EstadoCivil) VALUES ( @NombrePaciente, @ApellidoPaciente, @sexo, @Edad,@FechaNacimiento,@Telefono,@EstadoCivil)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = p.ObtenerParametros(cmd);

               cmd.ExecuteNonQuery();
            }
        }
        public static void EliminarPaciente(Paciente p)
        {
            //listaPacientes.Remove(p);
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"delete from Paciente where Id = @Id";

                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = p.ObtenerParametroId(cmd);

                cmd.ExecuteNonQuery();
            }
        }

        public static void EditarPaciente(int index, Paciente p)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"UPDATE Paciente SET NombrePaciente = @NombrePaciente, ApellidoPaciente = @ApellidoPaciente ,sexo = @sexo, Edad = @Edad, FechaNacimiento = @FechaNacimiento,Telefono = @Telefono,EstadoCivil = @EstadoCivil where Id = @Id";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = p.ObtenerParametros(cmd, true);

                cmd.ExecuteNonQuery();
            }
        }

        public static List<Paciente> ObtenerPacientes()
        {
            //return listaPacientes;

            Paciente paciente;
            listaPacientes.Clear();

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = "select * from Paciente";
                SqlCommand cmd = new SqlCommand(textoCmd, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    paciente = new Paciente();
                    paciente.Id = elLectorDeDatos.GetInt32(0);                    
                    paciente.NombrePaciente = elLectorDeDatos.GetString(1);
                    paciente.ApellidoPaciente = elLectorDeDatos.GetString(2);
                    paciente.sexo = (Sexo)elLectorDeDatos.GetInt32(3);
                    paciente.Edad = elLectorDeDatos.GetInt32(4);
                    paciente.FechaNacimiento = elLectorDeDatos.GetDateTime(5);
                    paciente.Telefono = elLectorDeDatos.GetInt32(6);
                    paciente.estadocivil = (EstadoCivil)elLectorDeDatos.GetInt32(7);



                    listaPacientes.Add(paciente);

                }
            }
            return listaPacientes;
        }

       

        public static Paciente ObtenerPaciente(int id)
        {
            Paciente paciente = null;

            if (listaPacientes.Count == 0) Paciente.ObtenerPacientes();

            foreach (Paciente p in listaPacientes)
            {
                if (p.Id == id)
                {
                    paciente = p;
                    break;
                }

            }
            return paciente;
        }

        public override string ToString()
        {
            return this.NombrePaciente+ " " + ApellidoPaciente;
        }

        private SqlCommand ObtenerParametros(SqlCommand cmd, Boolean Id = false)
        {
            
            SqlParameter p2 = new SqlParameter("@NombrePaciente", this.NombrePaciente);
            SqlParameter p3 = new SqlParameter("@ApellidoPaciente", this.ApellidoPaciente);
            SqlParameter p4 = new SqlParameter("@Sexo", this.sexo);
            SqlParameter p5 = new SqlParameter("@Edad", this.Edad);
            SqlParameter p6 = new SqlParameter("@FechaNacimiento", this.FechaNacimiento);
            SqlParameter p7 = new SqlParameter("@Telefono", this.Telefono);
            SqlParameter p8 = new SqlParameter("@EstadoCivil", this.estadocivil);
            
            p2.SqlDbType = SqlDbType.VarChar;
            p3.SqlDbType = SqlDbType.VarChar;
            p4.SqlDbType = SqlDbType.Int;
            p5.SqlDbType = SqlDbType.Int;
            p6.SqlDbType = SqlDbType.DateTime;
            p7.SqlDbType = SqlDbType.Int;
            p8.SqlDbType = SqlDbType.Int;
          
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
