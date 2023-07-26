# No Longer Maintained
This library is no longer maintained by CHHS.  If you, or your organization would like to take ownership of this repository, please get in contact with us.

# LiaisonCAS.Net

Liaison CAS is a .Net implementation (client SDK) for the LiaisonEDU CAS API (https://api.liaisonedu.com/reference/index.htm).  With this client you can programatically interact with the Liaison API with .Net languages.

### Getting Started

#### Installation

#### Usage

Instantiate a new instance of the ILiaisonCASClient using your APikey, username, and password.

```
ILiaisonCASClient client = new LiaisonCASClient("my-api-key", "myusername", "mypassword");
```

Before you can make calls to the Liaison API you need to set your authentication header token.  This is done seperately
from the client constructor to prevent multiple unnecessary calls in a dependency injected scenario, like Asp.Net Core.  However,
if you register this service as a singleton, you can skip calling the setup header, by configuring the client as follows:

```
ILiaisonCASClient client = new LiaisonCASClient("my-api-key", "myusername", "mypassword", true);
```


Call one of the following (depending on your async status)

```
client.SetupAuthenticationHeader();
```

or

```
await client.SetupAuthenticationHeadersAsync();
```

