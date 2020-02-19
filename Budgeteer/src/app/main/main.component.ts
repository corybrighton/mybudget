import { Component, OnInit } from '@angular/core';
import { AuthService } from '../services/auth.service';
import { AccountsService } from '../services/accounts.service';

@Component({
  selector: 'app-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.scss']
})
export class MainComponent implements OnInit {
  accountFlow;
  opened = true;
  private drawers = {
    profile: "profile",
    weather: "weather",
    accounts: "accounts"
  }
  openedDrawer: string = this.drawers.accounts;

  constructor(private accountService: AccountsService) { }

  ngOnInit() {
    this.getAccounts();
  }

  openDrawer(drawer: string) {
    if (this.drawers.hasOwnProperty(drawer)) {
      this.openedDrawer = this.drawers[drawer];
    }
  }

  getAccounts() {
    this.accountService.getAccountFlow().subscribe(res => this.accountFlow = res);
  }

}
