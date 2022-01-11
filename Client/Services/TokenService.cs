using IdentityModel.Client;
using Microsoft.Extensions.Options;

namespace Client.Services
{
	public class TokenService : ITokenService
	{
		public readonly IOptions<IdentityServerSettings> identityServerSettings;
		public readonly DiscoveryDocumentResponse discoveryDocument;
		private readonly HttpClient httpClient;

		public TokenService(IOptions<IdentityServerSettings> identityServerSettings)
		{
			this.identityServerSettings = identityServerSettings;
			httpClient = new HttpClient();
			discoveryDocument = httpClient.GetDiscoveryDocumentAsync(this.identityServerSettings.Value.DiscoveryUrl).Result;

			if (discoveryDocument.IsError)
			{
				throw new Exception("Unable to get discovery document", discoveryDocument.Exception);
			}
		}

		public Task<TokenResponse> GetToken(string scope)
		{
			throw new NotImplementedException();
		}
	}
}
