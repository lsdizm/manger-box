dotnet tool install --global dotnet-ef

sudo systemctl start mariadb

dotnet ef dbcontext scaffold "Server=127.0.0.0;user id=mj;password=20121104;Database=mj;" Pomelo.EntityFrameworkCore.MySql -o DB