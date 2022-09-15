// 1

class Address {
    constructor(index, country, city, street, house, apartment) {
      this.index = index,
      this.country = country,
      this.city = city,
      this.street = street,
      this.house = house,
      this.apartment = apartment
  };
};

function logAddress(address) {
  console.log(`
    Index: ${address.index},
    country: ${address.country},
    city: ${address.city},
    street: ${address.street},
    house:  ${address.house},
    apartament: ${address.apartment}
`)
};

const randomAddress = new Address(02232, 'Ukraine', 'Kyiv', 'Paper Street', '14/48', 448);
logAddress(randomAddress);

// 2

class Converter {
  constructor(doubleUsd, doubleEur, doubleRub) {
    this.doubleUsd = doubleUsd,
    this.doubleEur = doubleEur,
    this.doubleRub = doubleRub
  }
}
let currentExchangePrice = new Converter(36.73, 36.71, 0.62)

function convertUah(value, currentExchangePrice) {
  value /= currentExchangePrice
  console.log(value.toFixed(2));
}

convertUah(5000, currentExchangePrice.doubleUsd);
convertUah(5000, currentExchangePrice.doubleEur);
convertUah(5000, currentExchangePrice.doubleRub);

// 3 

class Employee{
  constructor(empName, empSurname, rank, workExperience) {
    this.empName = empName,
    this.empSurname = empSurname,
    this.rank = rank,
    this.workExperience = workExperience
  }

  showEmployee() {
    console.log(`
    employee Name: ${this.empName},
    employee Surname: ${this.empSurname},
    employee Rank: ${this.rank},
    employee Work Experience: ${this.workExperience},
    `)
  }

}

const randomEmployee = new Employee('Yevhenii', 'Sivukhin', 11, 7);
// !!! Не сделал Tax и Salary, потому что не совсем понял, какие я должен значения присвоить, зная rank и work Expirience

// 4 
class User {
  constructor(login, name, surname, age, regDate) {
    this.login = login,
    this.name = name,
    this.surname = surname,
    this.age = age,
    this.regDate = regDate
  }
}

const newUser = new User('randomLogin', 'randomName', 'randomSurname', 18, '15.09.2022');
// const newUser = new User('randomLogin', 'randomName', 'randomSurname', 18, '10.02.1999') <-- ERR
console.log(newUser);
