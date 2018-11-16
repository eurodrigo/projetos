using IO.Domain.Interfaces;
using IO.Infra.CrossCutting.AspNetFilters;
using IO.Infra.CrossCutting.Identity.Models;
using IO.Infra.CrossCutting.Identity.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace IO.Infra.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // ASPNET
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            //services.AddSingleton(Mapper.Configuration);
            //services.AddScoped<IMapper>(sp => new Mapper(sp.GetRequiredService<IConfigurationProvider>(), sp.GetService));

            //// Domain Bus (Mediator)
            //services.AddScoped<IMediatorHandler, MediatorHandler>();

            //// Domain - Commands
            //services.AddScoped<IRequestHandler<RegistrarEventoCommand>, EventoCommandHandler>();
            //services.AddScoped<IRequestHandler<AtualizarEventoCommand>, EventoCommandHandler>();
            //services.AddScoped<IRequestHandler<ExcluirEventoCommand>, EventoCommandHandler>();
            //services.AddScoped<IRequestHandler<AtualizarEnderecoEventoCommand>, EventoCommandHandler>();
            //services.AddScoped<IRequestHandler<IncluirEnderecoEventoCommand>, EventoCommandHandler>();
            //services.AddScoped<IRequestHandler<RegistrarOrganizadorCommand>, OrganizadorCommandHandler>();

            //// Domain - Eventos
            //services.AddScoped<INotificationHandler<DomainNotification>, DomainNotificationHandler>();
            //services.AddScoped<INotificationHandler<EventoRegistradoEvent>, EventoEventHandler>();
            //services.AddScoped<INotificationHandler<EventoAtualizadoEvent>, EventoEventHandler>();
            //services.AddScoped<INotificationHandler<EventoExcluidoEvent>, EventoEventHandler>();
            //services.AddScoped<INotificationHandler<EnderecoEventoAtualizadoEvent>, EventoEventHandler>();
            //services.AddScoped<INotificationHandler<EnderecoEventoAdicionadoEvent>, EventoEventHandler>();
            //services.AddScoped<INotificationHandler<OrganizadorRegistradoEvent>, OrganizadorEventHandler>();

            //// Infra - Data
            //services.AddScoped<IEventoRepository, EventoRepository>();
            //services.AddScoped<IOrganizadorRepository, OrganizadorRepository>();
            //services.AddScoped<IUnitOfWork, UnitOfWork>();
            //services.AddScoped<EventosContext>();

            //// Infra - Data EventSourcing
            //services.AddScoped<IEventStoreRepository, EventStoreSQLRepository>();
            //services.AddScoped<IEventStore, SqlEventStore>();
            //services.AddScoped<EventStoreSQLContext>();

            // Infra - Identity
            services.AddTransient<IEmailSender, AuthMessageSender>();
            services.AddTransient<ISmsSender, AuthMessageSender>();
            services.AddScoped<IUser, AspNetUser>();

            // Infra - Filtros
            services.AddScoped<ILogger<GlobalExceptionHandlingFilter>, Logger<GlobalExceptionHandlingFilter>>();
            services.AddScoped<ILogger<GlobalActionLogger>, Logger<GlobalActionLogger>>();
            services.AddScoped<GlobalExceptionHandlingFilter>();
            services.AddScoped<GlobalActionLogger>();
        }
    }
}
