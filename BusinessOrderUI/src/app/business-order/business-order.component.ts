import { BusinessOrderService } from './business-order.service';

export class BusinessOrderComponent {
    constructor(private BusinessOrderService: BusinessOrderService) { }
    reportData: any;
    showBusinessOrderReport() {
        this.BusinessOrderService.getBusinessOrderReport()
            .subscribe((data: any) => this.reportData
                // = {
                //     heroesUrl: data['heroesUrl'],
                //     textfile: data['textfile']
                // }
            )
            ;
    }

}