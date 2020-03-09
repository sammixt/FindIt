namespace Repository
{
    public interface IRepositoryWrapper
    {
        ILocalGovRepository GovRepository { get; }
        IStateRepository StateRepository { get; }
    }
}