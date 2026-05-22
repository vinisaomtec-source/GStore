using System.Data;
using System.Text;
using GStore.API.Models;
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
        List<Usuario> usuarios = [
            new Usuario() {
                Id = "a6115812-c07e-445b-a898-3f13b9276202",
                Email= "anthonyserrano894@gmail.com",
                NormalizedEmail ="ANTHONYSERRANO894@GMAIL.COM",
                UserName = "anthonyserrano894@gmail.com",
                NormalizedUserName = "ANTHONYSERRANO894@GMAIL.COM",
                LockoutEnabled = true,
                EmailConfirmed = true,
                Nome = "Administrador",
                DataNascimento = DateTime.Parse("22/12/2008"),
                Foto = "/img/usuarios/elfc6baa-ca55-4bb4-993c-fa5cd578c6aa.png" 
            },
        ];
        foreach (var usuario in usuarios)
        {
            PasswordHasher<Usuario> passwordHasher = new();
            usuario.PasswordHash = passwordHasher.HashPassword(usuario, "123456");   
        }
        builder.Entity<Usuario>().HasData(usuarios);

        #endregion


        #region  Usuario Perfil
        List<IdentityUserRole<string>>userRoles = [
            new () {
                UserId = usuarios[0].Id,
                RoleId = perfis[0].Id
            }
        ];
        builder.Entity<IdentityRole<string>>().HasData(userRoles);
        #endregion
    } 
}
