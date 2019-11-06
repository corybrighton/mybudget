import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Weather } from './Weather';
import { devServe, dev, prodServe } from './Env';

const serve = dev ? devServe : prodServe;

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json'
  })
};

@Injectable({
  providedIn: 'root'
})
export class WeatherService {

  constructor(private http: HttpClient) { }

  getWeather(): Observable<any> {
    return this.http.get(serve + "weatherforecast/", httpOptions);
  }

  getStarWars(): Observable<any> {
    return this.http.get("https://swapi.co/api/films/", httpOptions);
  }
}
