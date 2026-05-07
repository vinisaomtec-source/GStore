using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace GStore.API.Data.Seeds;

public class SeedUsuario
{
    public SeedUsuario(ModelBuilder builder)
    {
        #region  Perfil
        List<IdentityRole> perfis = [
           new(){
                Id = "a6115812-c07e-445b-a898-3f13b9276202",
                Name = "Administrador",
                NormalizedName = "ADMINISTRADOR"
           },
            new(){
                Id = "20f4dd6f-e55f-4c14-be1e-e15082d62ecd",
                Name = "Cliente",
                NormalizedName = "CLIENTE"
           },
        ];
        builder.Entity<IdentityRole>().HasData(perfis);
        #endregion

        #region  Usuarios
        #endregion

        #region  Usuario Perfil
        #endregion
    } 
}
