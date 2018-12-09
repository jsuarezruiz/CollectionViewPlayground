using Autofac;
using CollectionViewPlayground.Services;
using System;

namespace CollectionViewPlayground.ViewModels.Base
{
    public class Locator
    {
        private IContainer _container;
        private ContainerBuilder _containerBuilder;

        public static Locator Instance { get; } = new Locator();

        public Locator()
        {
            _containerBuilder = new ContainerBuilder();

            _containerBuilder.RegisterType<NavigationService>().As<INavigationService>();
            _containerBuilder.RegisterType<MonkeyService>().As<IMonkeyService>();

            _containerBuilder.RegisterType<BasicViewModel>();
            _containerBuilder.RegisterType<CarouselViewModel>();
            _containerBuilder.RegisterType<EmptyViewModel>();
            _containerBuilder.RegisterType<MainViewModel>();
            _containerBuilder.RegisterType<GridViewModel>();
            _containerBuilder.RegisterType<HorizontalListViewModel>();

            if (_container != null)
            {
                _container.Dispose();
            }

            _container = _containerBuilder.Build();
        }

        public T Resolve<T>()
        {
            return _container.Resolve<T>();
        }

        public object Resolve(Type type)
        {
            return _container.Resolve(type);
        }

        public void Register<TInterface, TImplementation>() where TImplementation : TInterface
        {
            _containerBuilder.RegisterType<TImplementation>().As<TInterface>();
        }

        public void Register<T>() where T : class
        {
            _containerBuilder.RegisterType<T>();
        }

        public void Build()
        {
            _container = _containerBuilder.Build();
        }
    }
}