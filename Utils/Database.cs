namespace IPG_MediaBrands.Utils;

public static class Database
    {
        public static IHost CreateDatabase(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            using (var appContext = scope.ServiceProvider.GetRequiredService<DBContext>())
            {
                try
                {
                    appContext.Database.EnsureCreated();
                }
                catch (Exception ex)
                {
                    var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "Un error creando la DB.");
                }
            }
            return host;
        }
    }