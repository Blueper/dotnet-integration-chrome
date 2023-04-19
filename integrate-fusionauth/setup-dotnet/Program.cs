using SampleApp; //
using Microsoft.AspNetCore.Authentication;

var builder = WebApplication.CreateBuilder(args);

// // Add services to the container.
// builder.Services.AddRazorPages();

var startup = new Startup(builder.Configuration); //
startup.ConfigureServices(builder.Services); //

var app = builder.Build();

// Configure the HTTP request pipeline.
// if (!app.Environment.IsDevelopment())
// {
//     app.UseExceptionHandler("/Error");
//     // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//     app.UseHsts();
// }

// app.UseHttpsRedirection();
// app.UseStaticFiles();

// app.UseRouting();

/**/
// Add this before any other middleware that might write cookies
app.UseCookiePolicy(new CookiePolicyOptions
{
    Secure = CookieSecurePolicy.Always
});

// app.UseAuthorization();

// app.MapRazorPages();

startup.Configure(app, builder.Environment); //


app.Run();

