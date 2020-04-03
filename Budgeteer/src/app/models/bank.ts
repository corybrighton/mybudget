import { Account } from '../models/account';
export class Bank {
  ID: number;
  BankName: string;
  accounts: Account[];
  total: number;
}
