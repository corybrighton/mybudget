import { Component, OnInit } from '@angular/core';
import { AuthService } from '../serverices/auth.service';

@Component({
  selector: 'app-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.scss']
})
export class MainComponent implements OnInit {
  opened = true;
  private drawers = {
    profile: "profile",
    weather: "weather"
  }
  openedDrawer: string = this.drawers.profile;

  constructor(private auth: AuthService) { }

  ngOnInit() {
  }

  openDrawer(drawer: string) {
    if (this.drawers.hasOwnProperty(drawer)) {
      this.openedDrawer = this.drawers[drawer];
    }
  }

}
