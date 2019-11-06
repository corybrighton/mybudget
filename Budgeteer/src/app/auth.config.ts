import { client_id, domain } from './Env';

// src/app/services/auth.config.ts

export const AUTH_CONFIG = {
  // Needed for Auth0 (capitalization: ID):
  clientID: client_id,
  // Needed for Auth0Cordova (capitalization: Id):
  clientId: client_id,
  domain: domain,
  packageIdentifier: 'com.brightmerlin.budgeteer' // config.xml widget ID, e.g., com.auth0.ionic
};