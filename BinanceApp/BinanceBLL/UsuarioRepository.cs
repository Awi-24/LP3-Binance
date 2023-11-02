namespace BinanceBLL;

using BinanceDAL.DBContext;
using BinanceMODEL;
using Microsoft.Identity.Client;

public class UsuarioRepository
{
        
        public static void Add(Usuario usuario) 
        {

            using (var dbContext = new CUsersRafaelDocumentsAcademicosSenai20232Lp3Av2Lp3BinanceBinanceappBinancedalDatabaseDatabase01MdfContext())
            {
                dbContext.Add(usuario);
                dbContext.SaveChanges();

            }

        }
        public static Usuario GetById(int id)
        {
            
            using (var dbContext = new CUsersRafaelDocumentsAcademicosSenai20232Lp3Av2Lp3BinanceBinanceappBinancedalDatabaseDatabase01MdfContext())
            { 
                var usuario = dbContext.Usuarios.Single(p => p.Id == id);
                return usuario;
        
            }   
    
        }
        
        public static List<Usuario> GetAll()
        {
            using (var dbContext = new CUsersRafaelDocumentsAcademicosSenai20232Lp3Av2Lp3BinanceBinanceappBinancedalDatabaseDatabase01MdfContext)
            {
                var usuario = dbContext.Usuarios.ToList();
                return usuario;
             
            }    
    
        }

        public static void Update(Usuario usuario) 
        {
            using (var dbContext = new CUsersRafaelDocumentsAcademicosSenai20232Lp3Av2Lp3BinanceBinanceappBinancedalDatabaseDatabase01MdfContext())
            {
                var usuario = dbContext.Usuarios.Single(p => p.Id == usuario.id);
                usuario.Nome = usuario.Nome;
                usuario.Senha = usuario.Senha;
                dbContext.SaveChanges();
            
            }
    
        }
        
        public static void Excluir(Usuario usuario)
        {
            using (var dbContext = new CUsersRafaelDocumentsAcademicosSenai20232Lp3Av2Lp3BinanceBinanceappBinancedalDatabaseDatabase01MdfContext())
            {
                var usuario = dbContext.Usuarios.Single(p => p.Id == usuario.id);
                dbContext.Remove(usuario);
                dbContext.SaveChanges();
            
            }
                
        }
}
