using Serenity.Navigation;
using Administration = Serene1.Administration.Pages;

[assembly: NavigationMenu(2000, "Administration", icon: "fa-desktop")]
[assembly: NavigationLink(2100, "Administration/Languages", typeof(Administration.LanguageController), icon: "fa-comments")]
[assembly: NavigationLink(2200, "Administration/Translations", typeof(Administration.TranslationController), icon: "fa-comment-o")]
[assembly: NavigationLink(2300, "Administration/Roles", typeof(Administration.RoleController), icon: "fa-lock")]
[assembly: NavigationLink(2400, "Administration/User Management", typeof(Administration.UserController), icon: "fa-users")]