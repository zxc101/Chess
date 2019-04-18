using Zenject;

public class InstallerDI : MonoInstaller<InstallerDI>
{
    public override void InstallBindings()
    {
        Container.Bind<IBoardManager>().To<BoardManager>().AsSingle();
    }
}