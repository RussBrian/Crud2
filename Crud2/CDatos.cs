using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Crud2
{
    internal class CDatos
    {
        DBfinal_P1Entities db;
        public void Crear(producto producto)
        {
            try
            {
             using (db = new DBfinal_P1Entities())
                {
                db.productos.Add(producto);
                db.SaveChanges();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            
          
        }

        public List<producto> Read()
        {
            try
            {
                using (db = new DBfinal_P1Entities())
                {
                    return db.productos.ToList();
                }
            }
          catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public void update(producto producto)
        {
            try
            {
                using(db = new DBfinal_P1Entities())
                {
                    db.Entry(producto).State=EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void delete(int pID)
        {
            try
            {
                using(db= new DBfinal_P1Entities())
                {
                    db.productos.Remove(db.productos.Single(p => p.id == pID));
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<producto> buscarID(int pID)
        {
            try
            {
                using (db= new DBfinal_P1Entities())
                {
                    return db.productos.Where(p=>p.id == pID).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public List<producto> buscarNombre(string pNombre)
        {
            try
            {
                using(db=new DBfinal_P1Entities())
                {
                    return db.productos.Where
                        (p =>p.nombre.Contains(pNombre)).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }

  
}
