import { Component, OnInit } from '@angular/core';
import { AccountsService } from '../../services/accounts.service';
import { Bank } from '../../models/bank';

@Component({
  selector: 'app-accounts',
  templateUrl: './accounts.component.html',
  styleUrls: ['./accounts.component.scss']
})
export class AccountsComponent implements OnInit {

  banks: Bank[];
  editing: boolean = false;

  constructor(private accountservice: AccountsService) { }

  ngOnInit() {
    this.accountservice.getAccounts().subscribe(res => this.banks = res)
  }

  editBank() {
    this.editing = !this.editing;
  }

  addBank() {
    let newBank: Bank =
    {
      ID: 4,
      name: "New Bank",
      accounts: [
        {
          ID: 1,
          Name: "Savings",
          BankID: 1,
          Uncleared: 0.23,
          Balance: 43.75
        }
      ],
      total: 102.1
    }
    this.banks.push(newBank);
  }

  saveBank() {
    let newBank: Bank =
    {
      ID: 12,
      "name": "New Bank",
      "accounts": [
        {
          "ID": 1,
          "Name": "Savings",
          "BankID": 1,
          "Uncleared": 0.23,
          "Balance": 43.75
        }
      ],
      "total": 102.1
    }
    this.accountservice.addBank(newBank).subscribe(res => console.log(res));
  }

}
