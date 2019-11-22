import { Component, OnInit } from '@angular/core';
import { WeatherService } from '../serverices/weather.service';

@Component({
  selector: 'app-weather',
  templateUrl: './weather.component.html',
  styleUrls: ['./weather.component.scss']
})
export class WeatherComponent implements OnInit {
  weather;
  constructor(public weatherforecast: WeatherService) { }

  ngOnInit() {
    this.weatherforecast.getweather().subscribe(res => {
      this.weather = res;
    });
  }

}
