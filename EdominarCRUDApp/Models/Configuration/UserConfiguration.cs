using EdominarCRUDApp.Models.db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EdominarCRUDApp.Models.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                 new User
                 {
                     Id = 1,
                     Name = "Shubho Das",
                     Mobile = "987456123",
                     Email = "das@gmail.com",
                     Gender = 1,
                     StateId = 28,
                     HobbyId = 4,
                     Address = "Chowrangi Road "
                 },
             new User
             {
                 Id = 2,
                 Name = "Anushka Das",
                 Mobile = "9874466123",
                 Email = "anushka@gmail.com",
                 Gender = 0,
                 StateId = 29,
                 HobbyId = 5,
                 Address = "61/2 Chowrashta Road"
             });
        }
    }
}
