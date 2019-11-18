import { Component, OnInit } from '@angular/core';
import { WeatherService } from '../serverices/weather.service';

@Component({
  selector: 'app-weather',
  templateUrl: './weather.component.html',
  styleUrls: ['./weather.component.sass']
})
export class WeatherComponent implements OnInit {
  weather;
  constructor(public weatherforecast: WeatherService) { }

  ngOnInit() {
    this.weatherforecast.getweather().subscribe(res => {
      console.log("weather component");
      console.log(res)
      this.weather = res
    });
  }

}
