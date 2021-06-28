import React from "react";
import { useHistory } from "react-router-dom";
import { Auth0Provider } from "@auth0/auth0-react";
import { getConfig } from "../config";


const Auth0ProviderWithHistory = ({ children }) => {
//   const domain = process.env.REACT_APP_AUTH0_DOMAIN;
//   const clientId = process.env.REACT_APP_AUTH0_CLIENT_ID;

  const history = useHistory();

  const onRedirectCallback = (appState) => {
    history.push(appState?.returnTo || window.location.pathname);
  };

    // Please see https://auth0.github.io/auth0-react/interfaces/auth0provideroptions.html
    // for a full list of the available properties on the provider
    const config = getConfig();

    const providerConfig = {
        domain: config.domain,
        clientId: config.clientId,
        ...(config.audience ? { audience: config.audience } : null),
        redirectUri: window.location.origin,
        onRedirectCallback,
    };

  return (
    <Auth0Provider
    {...providerConfig}
    >
      {children}
    </Auth0Provider>
  );
};

export default Auth0ProviderWithHistory;