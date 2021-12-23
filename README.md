# windows_auth_form_sql_server
Windows Authorization form on C# with getting logins from SQL Server

Было задание: Создать форму авторизации, чтобы логины и пароли проверялись напрямую из SQL сервера

**1) Сначала в файле Program.cs изменяем первую форму, которая должна выводиться, теперь не главное меню, а форма авторизации**

```С
using System;
using System.Windows.Forms;

namespace RGR
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AuthorizationForm());  // это первая загружаемая форма при запуске приложения
        }
    }
}
```

**2) На самом сервере (SQL SERVER) создаем логины для входа**


-- Создаем логины для хода в БД 
```sql
create login AdminLogin with password='P@ssw0rd1'
create login UserLogin with password='P@ssw0rd2'
go
create user admin_user for login AdminLogin
create user user_user for login UserLogin
```

![image](https://user-images.githubusercontent.com/89765480/147168899-68941793-f801-480d-a7a5-352c355cd8ea.png)


**3) Проверяем локально: заходим с самого SQL SERVER**

 ![image](https://user-images.githubusercontent.com/89765480/147168910-385d5db1-645c-44f9-b9ab-979411304793.png)

У логина должен быть доступ для соединения к БД
А также доступна проверка подлинности SQL сервера

![image](https://user-images.githubusercontent.com/89765480/147168917-3d6caad3-9bc3-4540-ac7f-bcea3a71c6f3.png)
![image](https://user-images.githubusercontent.com/89765480/147168920-86372e37-69cd-456c-8e16-83c4601b92a3.png)

**4) Создаем шаблон формы авторизации**

![image](https://user-images.githubusercontent.com/89765480/147169093-c1f073f4-19fe-49a1-a21d-1c80798ec046.png)

Графически будет выглядеть примерно так,
Ну и главное меню, которое дальше можно кастомизировать

![image](https://user-images.githubusercontent.com/89765480/147169132-4b1b638c-d2a9-439b-a7fc-45611d537460.png)

 


 



