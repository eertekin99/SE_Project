package com.example.demo.repository;

import com.example.demo.Entity.Customer;
import org.springframework.data.jpa.repository.JpaRepository;

public interface CustomerRepository extends JpaRepository<Customer,Long> {
    Customer findCustomerByCMobile(String mobile);
    Customer findCustomerByCMobileAndCMobile(String mobile, String mobile1);
}
