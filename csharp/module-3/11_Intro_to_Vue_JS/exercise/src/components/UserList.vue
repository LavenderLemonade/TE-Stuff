<template>
  <div> 
  <table id="tblUsers">
    <thead>
    <tr>
        <th>First Name</th>
        <th>Last Name</th>
        <th>Username</th>
        <th>Email Address</th>
        <th>Status</th>
    </tr>
    </thead>
    <tbody>
      <tr>
        <td><input v-model="search.firstName" type="text" id="firstNameFilter"/></td>
        <td><input v-model="search.lastName" type="text" id="lastNameFilter"/></td>
        <td><input v-model="search.username" type="text" id="usernameFilter"/></td>
        <td><input v-model="search.emailAddress" type="text" id="emailFilter"/></td>
        <td>
          <select v-model="search.status" id="statusFilter">
            <option value="">Show All</option>
            <option value="Active">Active</option>
            <option value="Inactive">Inactive</option>
          </select>
        </td>
      </tr>
      <tr class = "user-list" v-for="user in filteredList" v-bind:key = "user">
        <td> {{user.firstName}} </td>
        <td> {{user.lastName}} </td>
        <td> {{user.username}} </td>
        <td> {{user.emailAddress}} </td>
        <td> {{user.status}} </td>
      </tr>
    </tbody>
  </table>


  </div>
</template>

<script>
export default {
  name: 'user-list',
  data() {
    return {
      search: {
        firstName: "" ,
        lastName: "" ,
        username: "",
        emailAddress: "",
        status: ""
      },
      users: [
        { firstName: 'John', lastName: 'Smith', username: 'jsmith', emailAddress: 'jsmith@gmail.com', status: 'Active' },
        { firstName: 'Anna', lastName: 'Bell', username: 'abell', emailAddress: 'abell@yahoo.com', status: 'Active' },
        { firstName: 'George', lastName: 'Best', username: 'gbest', emailAddress: 'gbest@gmail.com', status: 'Inactive' },
        { firstName: 'Ben', lastName: 'Carter', username: 'bcarter', emailAddress: 'bcarter@gmail.com', status: 'Active' },
        { firstName: 'Katie', lastName: 'Jackson', username: 'kjackson', emailAddress: 'kjackson@yahoo.com', status: 'Active' },
        { firstName: 'Mark', lastName: 'Smith', username: 'msmith', emailAddress: 'msmith@foo.com', status: 'Inactive' }
      ]
    }
  },
  computed: {
    filteredList() {

      let filteredUsers = this.users;

      if (this.search.firstName != '')
      {
        filteredUsers = filteredUsers.filter((user) => user.firstName.toLowerCase().includes(this.search.firstName.toLowerCase()));
      }

      if (this.search.lastName != '')
      {
        filteredUsers = filteredUsers.filter((user) => user.lastName.toLowerCase().includes(this.search.lastName.toLowerCase()));
      }

      if (this.search.username != '')
      {
        filteredUsers = filteredUsers.filter((user) => user.username.toLowerCase().includes(this.search.username.toLowerCase()));
      }

      if (this.search.emailAddress != '')
      {
        filteredUsers = filteredUsers.filter((user) => user.emailAddress.toLowerCase().includes(this.search.emailAddress.toLowerCase()));
      }

      if (this.search.status != '')
      {
        filteredUsers = filteredUsers.filter((user) => user.status === this.search.status);
      }

      return filteredUsers;
    }
  }
}


</script>

<style scoped>
table {
  margin-top: 20px;
  font-family:-apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif
}
th {
  text-transform: uppercase
}
td {
  padding: 10px;
}
tr.disabled {
  color: red;
}
input, select {
  font-size: 16px;
}



</style>
