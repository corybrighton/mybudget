import { Component, OnInit } from '@angular/core';
import { AuthService } from './serverices/auth.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  title = 'Budgeteer';
  opened = true;

  constructor(private auth: AuthService) { }

  ngOnInit() {
    this.auth.localAuthSetup();
    this.auth.handleAuthCallback();
  }
}
