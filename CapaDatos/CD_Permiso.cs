using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;


namespace CapaDatos
{
    public class CD_Permiso
    {
        public List<Permiso> Listar(int idusuario)
        {
            List<Componente> lista = new List<Componente>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select Componente.IdComponente, Nombre, TipoComponente, Estado ");
                    query.AppendLine("from UsuarioComponente ");
                    query.AppendLine("inner join Componente on UsuarioComponente.IdComponente = Componente.IdComponente ");
                    query.AppendLine("where UsuarioComponente.IdUsuario = @IdUsuario");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("IdUsuario", idusuario);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Componente componente = new Componente();
                        componente.IdComponente = Convert.ToInt32(dr["IdComponente"]);
                        componente.Nombre = dr["Nombre"].ToString();
                        componente.TipoComponente = dr["TipoComponente"].ToString();
                        componente.Estado = Convert.ToBoolean(dr["Estado"]);

                        lista.Add(componente);
                    }
                }
                catch (Exception ex)
                {
                    List<Permiso> listaPermisos = new List<Permiso>();
                    return listaPermisos;
                }
            }
            return DiferenciarComponentes(lista);
        }

        private List<Permiso> DiferenciarComponentes(List<Componente> lista)
        {
            List<Permiso> listaPermisos = new List<Permiso>();
            List<Componente> listaPermisoComponente = new List<Componente>();
            List<Componente> listaGrupoPermisoComponente = new List<Componente>();

            do
            {
                foreach (Componente componente in lista)
                {
                    if (componente.Estado)
                    {
                        if (componente.TipoComponente == "Permiso")
                        {
                            listaPermisoComponente.Add(componente);
                        }
                        else if (componente.TipoComponente == "GrupoPermiso")
                        {
                            listaGrupoPermisoComponente.Add(componente);
                        }
                    }
                }

                lista.Clear();

                foreach (Componente componentePermiso in listaPermisoComponente)
                {
                    using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                    {
                        try
                        {
                            StringBuilder query = new StringBuilder();
                            query.AppendLine("select IdPermiso, NombreMenu ");
                            query.AppendLine("from Permiso ");
                            query.AppendLine("inner join Componente on Permiso.IdComponente = Componente.IdComponente ");
                            query.AppendLine("where Permiso.IdComponente = @IdComponente");

                            SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                            cmd.Parameters.AddWithValue("IdComponente", componentePermiso.IdComponente);

                            oconexion.Open();

                            SqlDataReader dr = cmd.ExecuteReader();
                            while (dr.Read())
                            {
                                Permiso permiso = new Permiso()
                                {
                                    IdComponente = componentePermiso.IdComponente,
                                    Nombre = componentePermiso.Nombre,
                                    TipoComponente = componentePermiso.TipoComponente,
                                    Estado = componentePermiso.Estado,
                                    IdPermiso = Convert.ToInt32(dr["IdPermiso"]),
                                    NombreMenu = dr["NombreMenu"].ToString()
                                };
                                listaPermisos.Add(permiso);
                            }
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("Hay un error en la base de datos " + ex.Message);
                        }
                    }
                }

                foreach (Componente componenteGrupoPermiso in listaGrupoPermisoComponente)
                {
                    string idGrupoPermiso = "";
                    using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                    {

                        try
                        {
                            StringBuilder query = new StringBuilder();
                            query.AppendLine("select GrupoPermiso.IdGrupoPermiso, Nombre ");
                            query.AppendLine("from GrupoPermiso ");
                            query.AppendLine("inner join Componente on GrupoPermiso.IdComponente = Componente.IdComponente ");
                            query.AppendLine("where GrupoPermiso.IdComponente = @IdComponente");

                            SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                            cmd.Parameters.AddWithValue("IdComponente", componenteGrupoPermiso.IdComponente);

                            oconexion.Open();

                            SqlDataReader dr = cmd.ExecuteReader();
                            while (dr.Read())
                            {
                                idGrupoPermiso = dr["IdGrupoPermiso"].ToString();
                            }
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("Hay un error en la base de datos " + ex.Message);
                        }
                    }
                    using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                    {
                        try
                        {
                            StringBuilder query = new StringBuilder();
                            query.AppendLine("select Componente.IdComponente, Nombre, TipoComponente, Estado ");
                            query.AppendLine("from Componente ");
                            query.AppendLine("inner join GrupoPermisoComponente on GrupoPermisoComponente.IdComponente = Componente.IdComponente ");
                            query.AppendLine("where GrupoPermisoComponente.IdGrupoPermiso = @IdGrupoPermiso ");

                            SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                            cmd.Parameters.AddWithValue("IdGrupoPermiso", idGrupoPermiso);

                            oconexion.Open();

                            SqlDataReader dr = cmd.ExecuteReader();
                            while (dr.Read())
                            {
                                Componente componenteDiferenciado = new Componente()
                                {
                                    IdComponente = Convert.ToInt32(dr["IdComponente"]),
                                    Nombre = dr["Nombre"].ToString(),
                                    TipoComponente = dr["TipoComponente"].ToString(),
                                    Estado = Convert.ToBoolean(dr["Estado"])
                                };
                                lista.Add(componenteDiferenciado);
                            }
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("Hay un error en la base de datos " + ex.Message);
                        }
                    }
                }

                listaPermisoComponente.Clear();
                listaGrupoPermisoComponente.Clear();

            }
            while (lista.Count != 0);

            return listaPermisos;
        }
        public List<Permiso> ListarPermisos()
        {
            List<Permiso> listaPermisos = new List<Permiso>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select Componente.IdComponente, Nombre, Estado, ");
                    query.AppendLine("Permiso.IdPermiso, Permiso.NombreMenu");
                    query.AppendLine("from Componente ");
                    query.AppendLine("inner join Permiso on Componente.IdComponente = Permiso.IdComponente ");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Permiso permiso = new Permiso();
                        permiso.IdComponente = Convert.ToInt32(dr["IdComponente"]);
                        permiso.Nombre = dr["Nombre"].ToString();
                        permiso.TipoComponente = "Permiso";
                        permiso.Estado = Convert.ToBoolean(dr["Estado"]);
                        permiso.IdPermiso = Convert.ToInt32(dr["IdPermiso"]);
                        permiso.NombreMenu = dr["NombreMenu"].ToString();

                        listaPermisos.Add(permiso);
                    }
                }
                catch (Exception ex)
                {
                    listaPermisos = new List<Permiso>();
                }
            }
            return listaPermisos;
        }
        public bool EditarEstado(int idComponente, bool estado, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_EditarEstadoPermiso", oconexion);

                    //PARAMETROS DE ENTRADA
                    cmd.Parameters.AddWithValue("IdComponente", idComponente);
                    cmd.Parameters.AddWithValue("Estado", estado);
                    //PARAMETRO DE SALIDA
                    cmd.Parameters.Add("Mensaje", SqlDbType.NVarChar, 400).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    //TIPO DE COMANDO
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    resultado = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }
                catch (Exception ex)
                {
                    resultado = false;
                }
            }
            return resultado;
        }
    }
}
