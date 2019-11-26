import { Component, OnInit } from '@angular/core';
import { AuthService } from '../services/auth.service';
import { AccountsService } from '../services/accounts.service';

@Component({
  selector: 'app-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.scss']
})
export class MainComponent implements OnInit {
  accounts;
  opened = true;
  private drawers = {
    profile: "profile",
    weather: "weather"
  }
  openedDrawer: string = this.drawers.profile;

  constructor(private accountS: AccountsService) { }

  ngOnInit() {
    this.getAccounts();
  }

  openDrawer(drawer: string) {
    if (this.drawers.hasOwnProperty(drawer)) {
      this.openedDrawer = this.drawers[drawer];
    }
  }

  getAccounts() {
    this.accountS.getAccounts().subscribe(res => this.accounts = res);
  }

}
