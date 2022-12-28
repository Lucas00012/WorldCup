import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { CupTitle } from '../../model/cupTitle';
import { ApiService } from '../../services/api.service';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent implements OnInit{
  displayedColumns: string[] = ['cup year', 'location'];
  dataSource?: CupTitle[];
  isLoadingResults = true;

  constructor(private api: ApiService) {

  }
    ngOnInit(): void {
      this.api.getCupTitles().subscribe(result => {
        this.dataSource = result;
        console.log(this.dataSource);
        this.isLoadingResults = false;
      }, error => {
        console.log(error);
        this.isLoadingResults = false;
      });
    }


}
