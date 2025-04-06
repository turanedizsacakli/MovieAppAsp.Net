var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();

//app.MapGet("/", () => "Hello World!");
var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapControllerRoute(
//    name: "homePage",
//    pattern: "",
//    defaults: new { controller = "Home", action = "Index" }
//    );
//});




app.UseEndpoints(endpoints =>
{
        endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}"
        );
});

app.Run();
