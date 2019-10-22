import { Component, OnInit } from '@angular/core';
import { WeatherService } from '../weather.service';

@Component({
  selector: 'app-list',
  templateUrl: 'list.page.html',
  styleUrls: ['list.page.scss']
})
export class ListPage implements OnInit {
  private icons = [
    'flask',
    'wifi',
    'beer',
    'football',
    'basketball',
    'paper-plane',
    'american-football',
    'boat',
    'bluetooth',
    'build'
  ];

  public items: Array<{ title: string; note: string; icon: string }> = [];
  constructor(private data: WeatherService) {
    for (let i = 1; i < 6; i++) {
      this.items.push({
        title: 'Item ' + i,
        note: 'This is item #' + i,
        icon: this.icons[Math.floor(Math.random() * this.icons.length)]
      });
    }

    data.getWeather().subscribe(res => {
      res.forEach(item => this.items.push({
        title: `The Weather for ${item['date']}`,
        note: `Will be ${item['temperatureF']} degrees and ${item['summary']}`,
        icon: this.icons[Math.floor(Math.random() * this.icons.length)]
      }))
    });

    data.getStarWars().subscribe(res => console.log(res));
  }

  ngOnInit() {
  }

}
