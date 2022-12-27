import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public cupsTitles: ICupTitleDto[] = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<ICupTitleDto[]>(baseUrl + 'cupstitles').subscribe(result => {
      this.cupsTitles = result;
    }, error => console.error(error));
  }
}

interface ICupTitleDto {
  CupYear: number;
  Location: string;

}
