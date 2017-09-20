using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ColeccionPlayer : List<ColeccionPet>
    {
        public ColeccionPlayer()
        {

        }

        public bool ModificarUsuario(ColeccionPlayer myCollection,
             string user, string correo, string password)
        {
            if (myCollection.Exists(x => x.PlayerData.User.Equals(user)))
            {
                if (correo.Length > 0)
                {
                    myCollection.First(c => c.PlayerData.User.Equals(user)).PlayerData.Mail = correo;
                }
                if (password.Length > 0)
                {
                    myCollection.First(c => c.PlayerData.User.Equals(user)).PlayerData.Password = password;
                }
                return true;
            }

            return false;
        }


        public bool EliminarUsuario(ColeccionPlayer myCollection,
            string user)
        {
            if (myCollection.Exists(x => x.PlayerData.User.Equals(user)))
            {
                myCollection.Remove(myCollection.First(e => e.PlayerData.User.Equals(user)));
                return true;
            }

            return false;

        }

        public bool AgregarPet(ColeccionPlayer coleccion, Pet pet, string username)
        {
            //En caso de que exista el usuario pero no tenga mascota, solo se agrega
            if (coleccion.Exists(u => u.PlayerData.User.Equals(username) && u.PetData == null))
            {
                coleccion.First(c => c.PlayerData.User.Equals(username)).PetData = pet;

                return true;
            }
            //Si el usuario ya tiene mascota, se genera un nuevo elemento
            else if (coleccion.Exists(u => u.PlayerData.User.Equals(username) && u.PetData != null))
            {
                Player p = coleccion.First(c => c.PlayerData.User.Equals(username)).PlayerData;
                //EliminarUsuario(coleccion, username);

                ColeccionPet da = new ColeccionPet
                {
                    PetData = pet,
                    PlayerData = p
                };
                coleccion.Add(da);

                return true;
            }

            //Sino entra pos error :v
            return false;
        }

    }
}
