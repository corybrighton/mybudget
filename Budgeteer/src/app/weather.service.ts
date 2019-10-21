import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Weather } from './Weather';

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
    return this.http.get("https://localhost:5001/weatherforecast/", httpOptions);
  }

  getStarWars(): Observable<any> {
    return this.http.get("https://swapi.co/api/films/", httpOptions);
  }
}
