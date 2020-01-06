import { Account } from "../models/account";
export class Bank {
  ID: number;
  name: string;
  accounts: Account[];
  total: number;
}
