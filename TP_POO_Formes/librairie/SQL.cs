using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librairie
{
    public class SQL
    {
        private string IP = "172.19.0.4";
        //private string IP = "127.0.0.1";
        private string USER = "TpForme";
        private string MDP = "0550002D";
        private string DATABASE = "Tp_Forme";
        private MySqlConnection conn;
        public SQL()
        {
            string connStr = "server=" + this.IP + ";user=" + this.USER + ";database=" + this.DATABASE + ";port=3306;password=" + this.MDP;
            conn = new MySqlConnection(connStr);
        }
        public List<Carre> GetAllCarre()
        {
            List<Carre> LesCarre = new List<Carre>();
            string requete = "SELECT * FROM Carre";
            MySqlCommand larequete = new MySqlCommand(requete, this.conn);
            this.conn.Open();
            MySqlDataReader Donner = larequete.ExecuteReader();
            while (Donner.Read())
            {
                LesCarre.Add(new Carre(Convert.ToInt32(Donner["id_Carre"]), Convert.ToInt32(Donner["Cote_Carre"]), Convert.ToInt32(Donner["X_Carre"]), Convert.ToInt32(Donner["Y_Carre"])));
            }
            this.conn.Close();
            return LesCarre;
        }
        public void AddCarre(int id ,int co , int x , int y)
        {
            string req = "INSERT INTO Carre(`id_Carre`,`Cote_Carre`,`X_Carre`,`Y_Carre`) VALUE ('"+id+"','"+co+"','"+x+"','"+y+"')";
            MySqlCommand larequete = new MySqlCommand(req, this.conn);
            this.conn.Open();
            MySqlDataReader Donner = larequete.ExecuteReader();
            this.conn.Close();
        }
        public List<Cercle> GetAllCercle()
        {
            List<Cercle> LesCercle = new List<Cercle>();
            string requete = "SELECT * FROM Cercle";
            MySqlCommand larequete = new MySqlCommand(requete, this.conn);
            this.conn.Open();
            MySqlDataReader Donner = larequete.ExecuteReader();
            while (Donner.Read())
            {
                LesCercle.Add(new Cercle(Convert.ToInt32(Donner["id_Cercle"]), Convert.ToInt32(Donner["rayon"]), Convert.ToInt32(Donner["X_Cercle"]), Convert.ToInt32(Donner["Y_Cercle"])));
            }
            this.conn.Close();
            return LesCercle;
        }
        public void AddCercle(int id, int ra, int x, int y)
        {
            string req = "INSERT INTO Cercle(`id_Cercle`,`rayon`,`X_Cercle`,`Y_Cercle`) VALUE ('" + id + "','" + ra + "','" + x + "','" + y + "')";
            MySqlCommand larequete = new MySqlCommand(req, this.conn);
            this.conn.Open();
            MySqlDataReader Donner = larequete.ExecuteReader();
            this.conn.Close();
        }
        public List<Rectangle> GetAllRectangle()
        {
            List<Rectangle> LesRectangle = new List<Rectangle>();
            string requete = "SELECT * FROM Rectangle";
            MySqlCommand larequete = new MySqlCommand(requete, this.conn);
            this.conn.Open();
            MySqlDataReader Donner = larequete.ExecuteReader();
            while (Donner.Read())
            {
                LesRectangle.Add(new Rectangle(Convert.ToInt32(Donner["id_Rectangle"]), Convert.ToInt32(Donner["longeur_Rectangle"]), Convert.ToInt32(Donner["largeur_Rectangle"]), Convert.ToInt32(Donner["X_Rectangle"]), Convert.ToInt32(Donner["Y_Rectangle"])));
            }
            this.conn.Close();
            return LesRectangle;
        }
        public void AddRectangle(int id, int lo,int la, int x, int y)
        {
            string req = "INSERT INTO Rectangle(`id_Rectangle`,`longeur_Rectangle`,`largeur_Rectangle`,`X_Rectangle`,`Y_Rectangle`) VALUE ('" + id + "','" + lo + "','" + la + "','" + x + "','" + y + "')";
            MySqlCommand larequete = new MySqlCommand(req, this.conn);
            this.conn.Open();
            MySqlDataReader Donner = larequete.ExecuteReader();
            this.conn.Close();
        }
    }
    
}
