import { Component, OnInit } from '@angular/core';
import { BusinessOrderService } from './business-order/business-order.service';
import { MatTableDataSource } from '@angular/material/table';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  providers: [BusinessOrderService],
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {

  title = 'İş Emirleri Raporu';
  displayedColumns: string[] = [];
  dataSource: any;

  constructor(private businessOrderService: BusinessOrderService) { }

  reportData: any;
  ngOnInit(): void {
    const th = this;
    this.businessOrderService.getBusinessOrderReportTable()
      .subscribe((data: any) => {
        //FILL TABLE DATASOURCE 
        let table = [];
        var obj = [];
        const aData = JSON.parse(data);
        let i = 0;
        for (let index = 0; index < aData.length; index++) {
          const element = aData[index];
          Object.keys(element).forEach(function (k) {
            obj.push(element[k]);
          });
          table.push(obj);
          obj = [];
        }
        //CREATE DISPLAYED COLUMNS DYNAMICALLY
        this.displayedColumns = [];
        for (let v in aData[0]) {
          this.displayedColumns.push(v);
        }
        //INITIALIZE MatTableDataSource
        this.dataSource = new MatTableDataSource(table);
      });
  }
}
