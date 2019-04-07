using Zenject;

namespace DI
{
    public class DefaultInstaller : MonoInstaller<DefaultInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<ILightManager>().To<LightManager>().AsSingle();
            Container.Bind<IGameManager>().To<GameManager>().AsSingle();
            Container.Bind<ISFXManager>().To<SFXManager>().AsSingle();
        }
    }
}