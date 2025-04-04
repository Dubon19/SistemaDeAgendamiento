using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Data.Entity;

namespace DAL
{
    public static class DAL_Usuarios
    {
        public static Usuarios Insert(Usuarios Entidad)
        {
            using (DBGestionCita bd = new DBGestionCita())
            {
                Entidad.Activo = true;
                Entidad.FechaCreacion = DateTime.Now;

                // Aquí deberías asegurarte de que la contraseña se establezca correctamente
                if (Entidad.Contrasena == null || Entidad.Contrasena.Length == 0)
                {
                    // Asegúrate de encriptar la contraseña antes de guardarla
                    Entidad.Contrasena = EncriptarContrasena("defaultPassword"); // Aquí se debería usar un método para encriptar la contraseña
                }

                bd.Usuarios.Add(Entidad);
                bd.SaveChanges();
                return Entidad;
            }
        }

        public static byte[] EncriptarContrasena(string contrasena)
        {
            // Crea una instancia del algoritmo SHA-256
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Convierte la contraseña a un arreglo de bytes
                byte[] bytes = Encoding.UTF8.GetBytes(contrasena);

                // Devuelve la contraseña encriptada en formato byte[]
                return sha256Hash.ComputeHash(bytes);
            }
        }

        public static Usuarios Update(Usuarios Entidad)
        {
            using (DBGestionCita bd = new DBGestionCita())
            {
                var Registro = bd.Usuarios.Find(Entidad.UsuarioId);
                if (Registro == null)
                {
                    return new Usuarios();
                }

                // Actualiza los campos de usuario si han cambiado
                Registro.Usuario = Entidad.Usuario;
                Registro.RolId = Entidad.RolId;

                // Si la contraseña es diferente a la actual, se actualiza (sin encriptación)
                if (Entidad.Contrasena != null && Entidad.Contrasena.Length > 0)
                {
                    // Almacena la contraseña tal como está (sin encriptarla)
                    Registro.Contrasena = Entidad.Contrasena;  // Almacenar en texto plano
                }

                Registro.FechaModificacion = DateTime.Now;

                bd.SaveChanges();
                return Registro;
            }
        }

        public static bool Delete(int usuarioId)
        {
            using (DBGestionCita bd = new DBGestionCita())
            {
                var usuario = bd.Usuarios.Find(usuarioId);  // Buscar el usuario por el 'UsuarioId' (tipo int)
                if (usuario == null)
                {
                    return false;  // Si no se encuentra el usuario
                }

                usuario.Activo = false;  // Desactivar el usuario
                usuario.FechaModificacion = DateTime.Now;
                bd.SaveChanges();  // Guardar los cambios en la base de datos
                return true;  // Usuario eliminado
            }
        }

        public static Usuarios Registro(int IdRegistro)
        {
            using (DBGestionCita bd = new DBGestionCita())
            {
                return bd.Usuarios.Find(IdRegistro);
            }
        }

        public static List<Usuarios> Listar(bool Activo = true)
        {
            using (DBGestionCita bd = new DBGestionCita())
            {
                return bd.Usuarios
                         .Include(u => u.Rol) // Cargar la relación con Roles correctamente
                         .Where(a => a.Activo == Activo)
                         .ToList();
            }
        }
    }
}
