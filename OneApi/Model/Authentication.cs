using Newtonsoft.Json;

namespace OneApi.Model
{
	public class Authentication
	{
		public enum AuthType
		{
            IBSSO,
			OAUTH
		}

		public Authentication() : base()
		{
            Type = AuthType.IBSSO;
		}

		/// <summary>
		/// Initialize Authentication</summary>
		/// <param name="username"> </param>
		/// <param name="password"> </param>
		public Authentication(string username, string password) : this()
		{  
			Username = username;
			Password = password;
		}

		/// <summary>
		/// Initialize 'OAUTH' Authentication </summary>
		/// <param name="accessToken"> </param>
		public Authentication(string accessToken)
		{
			AccessToken = accessToken;
			Type = AuthType.OAUTH;
		}

		/// <summary>
		/// Get Authentication type </summary>
		/// <returns> AuthType - (AuthType.OAUTH, AuthType.IBSSO) </returns>
        [JsonProperty(PropertyName = "type")]
        public AuthType Type;

		/// <summary>
		/// Get 'Basic' Authentication user name </summary>
		/// <returns> String </returns>
        [JsonProperty(PropertyName = "username")]
        public string Username;

		/// <summary>
		/// Get Authentication password </summary>
		/// <returns> String </returns>
        [JsonProperty(PropertyName = "password")]
        public string Password;

        /// <summary>
        /// Get Ibsso token </summary>
        /// <returns> String </returns>
        [JsonIgnore]
        public string IbssoToken;

		/// <summary>
		/// Get 'OAuth' Authentication Access Token </summary>
		/// <returns> String </returns>
        [JsonProperty(PropertyName = "accessToken")]
        public string AccessToken;
	}
}