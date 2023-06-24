namespace Akunich.Extensions.Identity.Abstractions;

public interface IIdentityIdProvider<out TKey>
{
    TKey GetIdentityId();
}