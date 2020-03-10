namespace Repository
{
    public interface IRepositoryWrapper
    {
        ILocalGovRepository GovRepository { get; }
        IStateRepository StateRepository { get; }
        IMerchantRepository MerchantRepo { get;  }
    }
}