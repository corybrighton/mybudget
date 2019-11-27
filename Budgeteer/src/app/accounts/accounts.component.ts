import { Component, OnInit } from '@angular/core';
import { AccountsService } from '../services/accounts.service';

@Component({
  selector: 'app-accounts',
  templateUrl: './accounts.component.html',
  styleUrls: ['./accounts.component.scss']
})
export class AccountsComponent implements OnInit {

  accounts;

  constructor(private accountservice: AccountsService) { }

  ngOnInit() {
    this.accountservice.getAccounts().subscribe(res => this.accounts = res)
  }

}
