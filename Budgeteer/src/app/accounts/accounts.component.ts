import { Component, OnInit } from '@angular/core';
import { AccountsService } from '../services/accounts.service';
import { Bank } from '../models/bank';

@Component({
  selector: 'app-accounts',
  templateUrl: './accounts.component.html',
  styleUrls: ['./accounts.component.scss']
})
export class AccountsComponent implements OnInit {

  banks: Bank[];

  constructor(private accountservice: AccountsService) { }

  ngOnInit() {
    this.accountservice.getAccounts().subscribe(res => this.banks = res)
  }

  addBank() {
    let newBank: Bank =
    {
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
