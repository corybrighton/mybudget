import { Component, OnInit } from '@angular/core';
import { AuthService } from './severices/auth.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.sass']
})
export class AppComponent implements OnInit {
  title = 'Budgeteer';

  constructor(private auth: AuthService) { }

  ngOnInit() {
    this.auth.localAuthSetup();
    this.auth.handleAuthCallback();
  }
}
