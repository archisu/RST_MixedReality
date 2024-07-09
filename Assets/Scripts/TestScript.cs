////hi. i commented out the whole code for practicality -doa

//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using Trimble.Connect;
//using Trimble.Identity;
//using System;
//using Trimble.Connect.Client;
//using Trimble.Identity.OAuth.AuthCode;
//using System.Threading.Tasks;
//using System.IO;

//public class TestScript : MonoBehaviour
//{


//    public const string ServiceUri = "https://app21.connect.trimble.com/tc/api/2.0/";


//    private const string AuthorityUri = AuthorityUris.ProductionUri;

//    /// <summary>
//    /// The client credentials.
//    /// </summary>
//    private static readonly ClientCredential ClientCredentials = new ClientCredential("6d41df90-33f7-4b74-8bca-aacd1d4ad428", "kztdl5XNQDR3fcfbeFqtfcjuCzEa", "MS_Teams_Integration")
//    {
//        RedirectUri = new Uri("http://localhost")
//    };

//    readonly static string[] Scopes = new string[] { ClientCredentials.Name };

//    public static AuthenticationResult authenticationResult;
//    public static AuthenticationContext authCtx;// = new AuthenticationContext(ClientCredentials, tokenCache) { AuthorityUri = new Uri(AuthorityUri) };
//    public static AuthCodeCredentialsProvider credentialsProvider;// = new AuthCodeCredentialsProvider(authCtx);
//    public static TrimbleConnectClient client;// = new TrimbleConnectClient(new TrimbleConnectClientConfig { ServiceURI = new Uri(ServiceUri) }, credentialsProvider);
//                                              // public static TrimbleConnectClient clientStatic = new TrimbleConnectClient(new TrimbleConnectClientConfig { ServiceURI = new Uri(ServiceUri) }, credentialsProvider);

//    public static TokenCache tokenCache = new TokenCache();
//    // Start is called before the first frame update
//    void Start()
//    {

//        Login();

//    }

//    // Update is called once per frame
//    void Update()
//    {

//    }


//    public async Task Login()
//    {
//        //TODO: Encrypt file!

//        try
//        {
//            var pathview = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Local\\ZenZ";
//            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Local\\ZenZ"))
//            {
//                var path = Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Local\\ZenZ");
//            }
//            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Local\\ZenZ\\ZenZ.authresult"))
//            {
//                string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Local\\ZenZ\\ZenZ.authresult";


//                string authResultString = File.ReadAllText(path);

//                var authenticationResultOld = Trimble.Identity.AuthenticationResult.Deserialize(authResultString);


//                credentialsProvider = new AuthCodeCredentialsProvider(authCtx);

//                authenticationResult = await authCtx.AcquireTokenByRefreshTokenAsync(authenticationResultOld.RefreshToken);
//                client = new TrimbleConnectClient(new TrimbleConnectClientConfig { ServiceURI = new Uri(ServiceUri) }, credentialsProvider);
//                await client.InitializeTrimbleConnectUserAsync();

//                var cloExpiry = authenticationResult.IsNearExpiry();




//                string authResult = authenticationResult.Serialize();
//                //TODO : Get User Filepath
//                File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Local\\ZenZ\\ZenZ.authresult", authResult);



//                //authenticationResult = await authCtx.AcquireTokenByRefreshTokenAsync(refreshTKN);
//                //await client.InitializeTrimbleConnectUserAsync();

//            }
//            else
//            {
//                authCtx = new AuthenticationContext(ClientCredentials, tokenCache) { AuthorityUri = new Uri(AuthorityUri) };
//                credentialsProvider = new AuthCodeCredentialsProvider(authCtx);
//                authenticationResult = await authCtx.AcquireTokenAsync(new InteractiveAuthenticationRequest()
//                {
//                    Scope = $"openid {string.Join(" ", ClientCredentials.Name)}"
//                });
//                client = new TrimbleConnectClient(new TrimbleConnectClientConfig { ServiceURI = new Uri(ServiceUri) }, credentialsProvider);


//                string authResult = authenticationResult.Serialize();
//                //TODO : Get User Filepath
//                File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Local\\ZenZ\\ZenZ.authresult", authResult);
//                await client.InitializeTrimbleConnectUserAsync();
//            }

//        }
//        catch (Exception ex)
//        {
//            authCtx = new AuthenticationContext(ClientCredentials, tokenCache) { AuthorityUri = new Uri(AuthorityUri) };
//            credentialsProvider = new AuthCodeCredentialsProvider(authCtx);
//            authenticationResult = await authCtx.AcquireTokenAsync(new InteractiveAuthenticationRequest()
//            {
//                Scope = $"openid {string.Join(" ", ClientCredentials.Name)}"
//            });
//            client = new TrimbleConnectClient(new TrimbleConnectClientConfig { ServiceURI = new Uri(ServiceUri) }, credentialsProvider);



//            string authResult = authenticationResult.Serialize();
//            //TODO : Get User Filepath
//            File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Local\\ZenZ\\ZenZ.authresult", authResult);

//            await client.InitializeTrimbleConnectUserAsync();

//            Console.WriteLine(ex);
//        }

//    }


//    public AuthenticationContext GetAuthenticationContext()
//    {
//        authCtx = new AuthenticationContext(
//        ClientCredentials,
//                new TokenCache())
//        {
//            AuthorityUri = new Uri(AuthorityUri),

//        };
//        return authCtx;

//    }


//}
